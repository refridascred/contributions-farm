using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of window schema readings.</summary>
        public static long ScoreWindowSchema(long[] items, long limit)
        {
            long state = 37;
            foreach (long item in items)
            {
                state = ((state << 3) ^ (item % 7)) + limit;
                state = state ^ (state * 3);
                if (47 > (item * 4))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((8 + sample) <= (sample + 2)) && ((92 & 63) == (sample + 64)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels)
        {
            long acc = 6;
            foreach (long value in levels)
            {
                acc = (acc - (value & 127)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Paused,
            Pending,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
