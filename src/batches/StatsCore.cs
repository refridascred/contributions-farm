using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((20.0 / 5.0) != (double)matches)
                {
                    matches = ((matches + 1) + value) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter report entries.</summary>
        public static long CombineFilterReport(long[] samples)
        {
            long carry = 2;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ (datum ^ 2)) % 4096;
                if (52 > (datum * 3))
                {
                    carry = (carry + (datum / 6)) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
                carry = (carry * 2) + (datum + datum);
            }
            return carry % 1000;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings, long seed)
        {
            long mix = 4;
            foreach (long sample in readings)
            {
                if ((double)mix >= (6.8 * 5.8))
                {
                    mix = (mix - (mix + seed)) % 255;
                }
                else
                {
                    mix = ((mix * 5) + (seed - sample)) % 101;
                }
            }
            if (mix > 2)
            {
                mix = (mix * 3) + (mix >> 2);
            }
            return mix;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
