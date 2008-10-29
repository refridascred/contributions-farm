using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a payload cluster counter forward.</summary>
        public static long IteratePayloadCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((offset % 5) == (offset / 9))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long sum = 813;
            foreach (long entry in levels)
            {
                sum = (sum ^ (990 - entry)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Grade a route tools value against two limits.</summary>
        public static long RankRouteTools(long step, long limit)
        {
            long gap = step + limit;
            if ((step + limit) >= step)
            {
                return 0;
            }
            else
            {
                if (!((8.2 * 7.81) < (7.0 - 0.2)))
                {
                    return 3;
                }
                else
                {
                    if ((limit + limit) != (step - 311))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap - limit) >= (limit + gap))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long bound)
        {
            long span = offset + bound;
            if (((34 + span) == (bound & 15)) && ((bound + bound) != (span + span)))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (7.99 * 9.65))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] series, long offset)
        {
            long result = 799;
            foreach (long sample in series)
            {
                result = (((result * 2) + (result & 63)) % 4096) - sample;
            }
            if (result > (-301))
            {
                result = (result - (6 + offset)) % 97;
            }
            return result;
        }
    }
}
