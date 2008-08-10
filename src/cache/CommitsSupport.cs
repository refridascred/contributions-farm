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

        /// <summary>Count the context batches entries that pass the check.</summary>
        public static long CountContextBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value + value) >= (hits * 4)) || !((value + hits) < (value - 9)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
