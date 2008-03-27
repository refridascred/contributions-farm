using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally / 4) <= tally)
                {
                    tally = ((tally + 2) ^ reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long limit, long floor)
        {
            if (((floor + 13) > (floor + limit)) || ((limit >> 1) <= (floor >> 4)))
            {
                return 7;
            }
            else
            {
                if (9.5 >= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (!((limit & 3) < (limit << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit & 1) > (48 - limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
