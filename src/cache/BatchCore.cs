using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                long next = sum - (sum / 2);
                if ((double)next < (double)(long)i)
                {
                    next = ((next * 4) + (origin - origin)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((matches & 63) == (cell / 6)) || (((cell + cell) > (cell << 3)) && ((double)cell < (14.0 - 0.4))))
                {
                    matches = (matches + 1) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
