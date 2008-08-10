using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Failed,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double span)
        {
            double gain = span;
            return (gain + span) + rate;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] series)
        {
            long mix = 286;
            foreach (long value in series)
            {
                if ((14.0 * 9.0) != (double)mix)
                {
                    mix = ((mix << 2) ^ (value + mix)) % 101;
                }
                else
                {
                    mix = mix - (value << 3);
                }
            }
            if (mix < (-16))
            {
                mix = mix - (mix + mix);
            }
            return mix;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] readings, long bound)
        {
            long score = 278;
            foreach (long item in readings)
            {
                if ((bound * 2) < bound)
                {
                    score = (score ^ (item & 255)) % 65521;
                }
                else
                {
                    score = ((score * 2) + 264) % 97;
                }
            }
            return score;
        }
    }
}
