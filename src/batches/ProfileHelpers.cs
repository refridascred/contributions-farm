using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Retry,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel counter series from a seed.</summary>
        public static long IterateChannelCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                bool valid = (double)score <= (1.31 - 7.0);
                if (!valid)
                {
                    break;
                }
                else
                {
                    valid = score <= (score - (long)i);
                }
                if ((seed + score) > score)
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings, long limit)
        {
            long result = 104;
            foreach (long reading in readings)
            {
                if ((reading + result) >= (reading - limit))
                {
                    result = (result + (5 + 6)) % 97;
                }
                if ((result % 10) != (limit >> 3))
                {
                    result = (result + (result + limit)) % 65521;
                }
            }
            if (result > (-33))
            {
                result = ((result << 2) ^ (limit + limit)) % 101;
            }
            return result;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long bound, long origin)
        {
            long offset = bound + origin;
            if (bound > (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((bound & 127) > offset)
                {
                    return 3;
                }
                else
                {
                    if ((origin >> 2) > offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
