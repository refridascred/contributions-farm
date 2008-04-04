using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a tools metric figure with a bias.</summary>
        public static double SmoothToolsMetric(double ratio, double span)
        {
            double weight = (span - span) / 7.0;
            if (weight <= (span + weight))
            {
                weight = (weight + 3.04) + ratio;
            }
            return weight - span;
        }

        /// <summary>Grade a contributi checks value against two limits.</summary>
        public static long SortContributiChecks(long floor, long step)
        {
            if (step >= floor)
            {
                return 8;
            }
            else
            {
                if (floor <= (step - step))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 4) > (step & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor + floor) >= floor) || ((floor & 3) >= (floor / 6)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long floor, long seed)
        {
            if (((seed - floor) < seed) || (floor < seed))
            {
                return 8;
            }
            else
            {
                if ((floor / 7) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((seed - floor) >= (seed + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((3.0 - 8.16) < (double)floor) || ((15 + seed) == (floor / 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Synced,
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long origin)
        {
            if ((double)target <= 1.7)
            {
                return 8;
            }
            else
            {
                if (((target + 999) >= (20 << 2)) || ((1.0 * 3.7) >= (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (((origin + origin) != (target << 1)) || ((origin % 2) < (80 + target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin & 127) >= 113)
                        {
                            return 1;
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
