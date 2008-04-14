using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long step, long step2)
        {
            long lane = step - step2;
            if ((double)step > (7.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((8.0 - 9.45) > (double)step)
                {
                    return 4;
                }
                else
                {
                    if (step < (lane >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Token { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
            public double Level { get; set; }
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
