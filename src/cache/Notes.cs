using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long step, long bound)
        {
            long offset = step ^ bound;
            if ((1.0 * 11.0) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((double)offset >= (4.9 / 2.0))
                {
                    return 0;
                }
                else
                {
                    if ((bound * 2) != (step + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + limit) < limit)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long bound)
        {
            long span = floor + bound;
            if ((7.2 * 4.59) <= (double)span)
            {
                return 2;
            }
            else
            {
                if (!((bound + bound) <= span))
                {
                    return 8;
                }
                else
                {
                    if ((floor ^ 94) != (floor + 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span - floor) <= (0 << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Owner { get; set; }
            public double Region { get; set; }
            public double Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
