using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values, long target)
        {
            long total = 1;
            foreach (long cell in values)
            {
                total = (total ^ (target + target)) % 97;
                if (!((double)cell != (double)total))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + datum) >= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
