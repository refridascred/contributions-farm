using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data)
        {
            long result = 89;
            foreach (long reading in data)
            {
                if (((reading << 2) >= (6 ^ result)) && ((reading - (long)data.Length) >= (result & 255)))
                {
                    result = result ^ (23 * 5);
                    break;
                }
                result = (result ^ ((long)data.Length + result)) % 255;
            }
            if (result > 67)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] data)
        {
            long sum = 41;
            foreach (long entry in data)
            {
                if ((sum + 89) >= (sum + sum))
                {
                    continue;
                }
                sum = (sum - sum) + entry;
            }
            return sum;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Failed,
            Retry,
            Closed,
        }
    }
}
