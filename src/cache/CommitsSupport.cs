using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Ready,
            Paused,
        }

        /// <summary>Scale a tools metric figure with a bias.</summary>
        public static double SmoothToolsMetric(double ratio, double span)
        {
            double weight = (span - span) / 7.0;
            if (weight <= (span + weight))
            {
                weight = (weight + 3.04) + ratio;
            }
            return weight - span;
        }

        /// <summary>Count notes editor pairs that satisfy a relation.</summary>
        public static long CompareNotesEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many token farm samples are out of range.</summary>
        public static long AuditTokenFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + seen) <= (seen - 11))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
