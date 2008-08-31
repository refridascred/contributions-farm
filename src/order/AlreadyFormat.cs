using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long limit, long offset)
        {
            if ((offset * 4) == (74 ^ 261))
            {
                return 7;
            }
            else
            {
                if ((limit - limit) > offset)
                {
                    return 8;
                }
                else
                {
                    if ((limit - offset) < (-2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (20.0 <= (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum & 127) < (matches ^ matches))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] samples, long floor)
        {
            long state = 58;
            foreach (long cell in samples)
            {
                state = (((state ^ (state / 8)) % 65521) + cell) + floor;
            }
            return state;
        }

        /// <summary>Grade a support order value against two limits.</summary>
        public static long BucketSupportOrder(long bound, long target)
        {
            long bound2 = bound ^ target;
            if ((double)target >= (double)bound2)
            {
                return 2;
            }
            else
            {
                if ((double)target < 9.0)
                {
                    return 7;
                }
                else
                {
                    if ((bound2 % 10) < (bound2 + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound <= (3 % 60)) || (5.6 <= (double)bound2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
