using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels)
        {
            long score = 719;
            foreach (long value in levels)
            {
                score = score ^ (value - value);
                if ((double)value <= (20.0 + 5.4))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every batch command entry stays within the limit.</summary>
        public static bool ValidateBatchCommandRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
