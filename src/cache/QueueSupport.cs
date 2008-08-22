using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many notes graph samples are out of range.</summary>
        public static long CountNotesGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > (5.0 - 8.16))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] readings)
        {
            long carry = 211;
            foreach (long reading in readings)
            {
                if ((carry ^ reading) >= reading)
                {
                    carry = (carry - (reading & 3)) % 65521;
                }
            }
            if (carry > 181)
            {
                carry = (carry + (carry & 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Draft,
            Synced,
            Closed,
            Paused,
        }
    }
}
