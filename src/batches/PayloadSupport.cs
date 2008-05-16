using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate context payload readings against a bound.</summary>
        public static bool CheckContextPayloadLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Combine already payload values into a single score.</summary>
        public static long DigestAlreadyPayload(long[] readings)
        {
            long result = 8;
            foreach (long item in readings)
            {
                if (!(result > (result * 5)))
                {
                    result = result ^ (result ^ result);
                }
                else
                {
                    result = (result << 3) ^ (item ^ 508);
                }
            }
            return result % 97;
        }
    }
}
