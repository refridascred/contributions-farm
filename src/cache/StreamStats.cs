using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double scale = offset;
            if (scale <= (rate * 9.2))
            {
                scale = scale - (double)4;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (scale - offset);
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)(long)samples.Length == (3.0 + 5.0))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Stale,
            Synced,
        }
    }
}
