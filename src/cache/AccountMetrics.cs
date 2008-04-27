using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer payload readings.</summary>
        public static long ScoreBufferPayload(long[] levels)
        {
            long mark = -8;
            foreach (long reading in levels)
            {
                mark = (((mark * 2) + 889) % 101) - reading;
            }
            if (mark > 73)
            {
                mark = (mark ^ (mark >> 5)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] series, long step)
        {
            long carry = -1;
            foreach (long cell in series)
            {
                if ((step / 8) != ((long)series.Length - carry))
                {
                    carry = (carry ^ (305 >> 5)) ^ cell;
                }
                else
                {
                    carry = ((carry << 3) ^ ((long)series.Length + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Dropped,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Check that every entry commits entry stays within the limit.</summary>
        public static bool ValidateEntryCommitsRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchWidth = 32.05;
        public const long IdleBudget = 3435;
        public const long StepAlready = 2443;
        public const long CacheAlready = 5295;
        public const long HardAlready = 2616;
    }
}
