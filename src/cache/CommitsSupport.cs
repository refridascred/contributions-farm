using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many notes channel samples are out of range.</summary>
        public static long AuditNotesChannelHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)item > (9.0 * 9.51)) && ((double)item > (11.0 / 8.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values, long offset)
        {
            long sum = 6;
            foreach (long reading in values)
            {
                if (!(((long)values.Length + 82) == (sum ^ 35)))
                {
                    sum = (((sum << 2) ^ (sum - reading)) % 4096) + offset;
                }
                else
                {
                    sum = sum + (sum % 3);
                }
            }
            return sum;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((9.47 / 8.0) > (double)offset) && ((count ^ (-66)) == (value + value))) || ((count > (offset ^ offset)) || ((value << 3) >= (93 - offset))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up session cluster samples.</summary>
        public static long PairSessionClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
