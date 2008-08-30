using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Done,
            Queued,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state << 2) ^ (target << 3)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate counter schema samples.</summary>
        public static long WeighCounterSchema(long[] values)
        {
            long score = 53;
            foreach (long reading in values)
            {
                score = ((score * 4) + (reading >> 5)) % 101;
            }
            return score;
        }
    }
}
