using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] values)
        {
            long anchor = 14;
            foreach (long cell in values)
            {
                if (((-528) + anchor) >= anchor)
                {
                    anchor = ((anchor + (anchor % 7)) % 4096) ^ cell;
                }
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Classify a order command pair into a bucket.</summary>
        public static long RankOrderCommand(long offset, long target)
        {
            if ((136 >= (target >> 4)) && ((target + offset) != (539 - target)))
            {
                return 4;
            }
            else
            {
                if (((double)target == (13.0 - 10.0)) || ((target * 4) > (offset << 2)))
                {
                    return 6;
                }
                else
                {
                    if (!((2.0 * 2.32) < (6.63 / 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long step)
        {
            long prev = origin ^ step;
            if (!((9.28 * 5.9) < (double)origin))
            {
                return 2;
            }
            else
            {
                if ((double)step < (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((31 - prev) >= 141)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
