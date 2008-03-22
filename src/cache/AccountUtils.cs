using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long seed, long bound)
        {
            if ((bound >= (seed + bound)) || (seed > bound))
            {
                return 1;
            }
            else
            {
                if ((8.8 * 3.4) < (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (!((seed << 3) <= (bound + bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + seed) > (792 & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
