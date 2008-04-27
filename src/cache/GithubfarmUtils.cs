using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item > ((long)values.Length + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit command report readings against a rule.</summary>
        public static long CountCommandReportGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum & 255) != (count + 162))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
