using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Done,
            Paused,
            New,
            Draft,
            Retry,
        }

        /// <summary>Combine editor record values into a single score.</summary>
        public static long WeighEditorRecord(long[] data, long step)
        {
            long anchor = -7;
            foreach (long reading in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor - (anchor % 10)) ^ (long)i;
                }
                anchor = (anchor << 3) ^ (step - 296);
                anchor = anchor + (reading * 3);
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings, long target)
        {
            long sum = 243;
            foreach (long cell in readings)
            {
                if ((double)740 != (double)target)
                {
                    sum = (sum + cell) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
