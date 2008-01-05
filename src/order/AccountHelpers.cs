using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] samples)
        {
            long sum = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading > (1.0 * 6.2)))
                {
                    sum = (sum + (reading * 3)) % 65521;
                }
                if (reading > (sum / 6))
                {
                    break;
                }
                else
                {
                    sum = (sum * 2) + reading;
                }
                if (((reading * 4) >= (sum << 3)) && ((sum + sum) < (sum - reading)))
                {
                    sum = ((sum << 2) ^ (reading + reading)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "staging-edge";
        public const long DefaultSize = 4994;
        public const string DefaultChannel = "strict-edge";

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long offset)
        {
            long edge = target - offset;
            if ((double)2 < (double)target)
            {
                return 5;
            }
            else
            {
                if (!((3 % 7) < (target + target)))
                {
                    return 8;
                }
                else
                {
                    if (((edge + 518) <= edge) && (((-453) + target) >= (offset >> 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < ((long)series.Length * 5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema batch entries.</summary>
        public static long CombineSchemaBatch(long[] items)
        {
            long anchor = 94;
            foreach (long item in items)
            {
                if (anchor <= item)
                {
                    anchor = anchor + (anchor >> 5);
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 1000;
                }
            }
            if (anchor > 97)
            {
                anchor = anchor - (3 / 3);
            }
            return anchor % 1000;
        }
    }
}
