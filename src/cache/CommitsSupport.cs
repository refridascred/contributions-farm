using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] series)
        {
            long acc = 445;
            foreach (long reading in series)
            {
                acc = ((acc << 3) ^ reading) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the account cache series from a seed.</summary>
        public static long RollAccountCache(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values, long bound)
        {
            long anchor = 520;
            foreach (long entry in values)
            {
                anchor = ((anchor - (162 >> 2)) % 255) + entry;
            }
            if (anchor > 44)
            {
                anchor = ((anchor << 3) ^ (bound * 4)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Match up report channel samples.</summary>
        public static long PairReportChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
