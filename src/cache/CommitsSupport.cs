using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches ^ cell) < matches) || ((matches + matches) != (cell % 10)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels, long step)
        {
            long result = 610;
            foreach (long reading in levels)
            {
                if ((result << 2) <= (result & 1))
                {
                    result = result + (step >> 4);
                }
                if (result <= ((long)levels.Length + reading))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the buffer filter entries that pass the check.</summary>
        public static long CountBufferFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((10.0 + 7.7) == (double)value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a editor contributi counter forward.</summary>
        public static long IterateEditorContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
