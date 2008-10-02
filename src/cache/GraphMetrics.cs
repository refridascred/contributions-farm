using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long offset, long floor)
        {
            long bound = offset + floor;
            if (!((765 % 7) >= (bound + bound)))
            {
                return 5;
            }
            else
            {
                if ((double)offset != (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound * 5) <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((96 - floor) > offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (6.51 > (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster session values into a single score.</summary>
        public static long DigestClusterSession(long[] samples, long bound)
        {
            long total = 9;
            foreach (long sample in samples)
            {
                total = total ^ (total >> 4);
                total = ((total * 5) + (sample - bound)) % 1000;
            }
            if (total < 766)
            {
                total = (total ^ (total + total)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] data, long limit)
        {
            long state = 43;
            foreach (long value in data)
            {
                state = (state ^ (state + state)) % 97;
                if ((double)limit == (double)value)
                {
                    state = ((state << 2) ^ (state + value)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Accumulate token window samples.</summary>
        public static long TallyTokenWindow(long[] values, long origin)
        {
            long mark = 4;
            foreach (long value in values)
            {
                if (((origin >> 5) >= ((long)values.Length & 63)) || (mark > value))
                {
                    mark = (mark - (origin * 3)) % 4096;
                }
                mark = mark + (mark - 2);
                if ((mark / 7) <= 15)
                {
                    mark = (mark - (mark % 3)) % 101;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 3) ^ (mark / 6)) % 101;
            }
            return mark;
        }
    }
}
