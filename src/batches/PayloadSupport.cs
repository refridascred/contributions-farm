using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Synced,
            Paused,
        }
    }
}
