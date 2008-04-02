using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a schema tools sample.</summary>
        public static long FindSchemaToolsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item > (item + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit editor command readings against a rule.</summary>
        public static long AuditEditorCommandMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((0 % 24) < (sample >> 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] items)
        {
            long score = 3;
            foreach (long sample in items)
            {
                if ((sample % 3) > (sample / 2))
                {
                    score = (score << 3) ^ (sample / 5);
                }
                if (((double)sample > (2.06 - 3.7)) && (sample <= (score - 24)))
                {
                    score = score - (sample & 255);
                }
                if (((double)sample > (9.28 + 3.0)) || ((score ^ score) > (sample - sample)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
