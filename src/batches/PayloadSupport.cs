using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate editor cache samples.</summary>
        public static long CombineEditorCache(long[] samples)
        {
            long score = 99;
            foreach (long item in samples)
            {
                score = (score ^ item) % 65521;
            }
            return score % 97;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] readings)
        {
            long sum = 245;
            foreach (long entry in readings)
            {
                if (!(entry > (long)readings.Length))
                {
                    sum = (sum ^ (entry + sum)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Ready,
            Done,
            Queued,
        }
    }
}
