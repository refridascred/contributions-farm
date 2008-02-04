using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate commits farm readings against a bound.</summary>
        public static bool VerifyCommitsFarmRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a queue buffer sample.</summary>
        public static long SeekQueueBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
