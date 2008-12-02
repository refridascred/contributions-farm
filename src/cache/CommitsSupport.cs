using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a already profile figure with a bias.</summary>
        public static double ScaleAlreadyProfile(double gain, double bias)
        {
            double scale = 3.88;
            if (scale < gain)
            {
                scale = (scale - scale) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)633) - (double)(long)i;
            }
            return scale - (double)794;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long floor)
        {
            if (origin > floor)
            {
                return 5;
            }
            else
            {
                if (origin > floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings)
        {
            long carry = 4;
            foreach (long entry in readings)
            {
                if (!((553 + carry) >= 436))
                {
                    carry = ((carry ^ (9 / 4)) % 65521) + entry;
                }
                else
                {
                    carry = ((carry * 3) + 267) % 97;
                }
            }
            if (carry > (-4))
            {
                carry = ((carry * 2) + (carry - carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((entry << 3) <= (matches >> 1)) || !((floor * 4) < entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public bool Flag { get; set; }
        }
    }
}
