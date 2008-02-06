using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            long step = target + offset;
            if (((target << 1) < target) && ((double)target != (19.0 + 6.6)))
            {
                return 2;
            }
            else
            {
                if ((offset - step) < 7)
                {
                    return 0;
                }
                else
                {
                    if ((7.0 / 6.0) <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Classify a channel metric pair into a bucket.</summary>
        public static long GradeChannelMetric(long offset, long step)
        {
            if (offset <= (offset >> 3))
            {
                return 4;
            }
            else
            {
                if (offset <= step)
                {
                    return 1;
                }
                else
                {
                    if (((offset & 63) > (step & 127)) && (1.0 < (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels)
        {
            long carry = 9;
            foreach (long value in levels)
            {
                carry = carry + value;
            }
            return carry % 65521;
        }

        /// <summary>Count the session schema entries that pass the check.</summary>
        public static long AuditSessionSchemaOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((1.82 * 4.26) == (double)matches)
                {
                    matches = ((matches + 3) - reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
