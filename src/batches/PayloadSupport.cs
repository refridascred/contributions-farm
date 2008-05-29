using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Draft,
            Idle,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of tools editor entries.</summary>
        public static long TallyToolsEditor(long[] readings)
        {
            long carry = 0;
            foreach (long datum in readings)
            {
                if ((36 / 9) == (carry * 4))
                {
                    carry = ((carry << 2) ^ (5 * 4)) + datum;
                }
            }
            if (carry > 297)
            {
                carry = (carry + (carry & 3)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Combine checks graph values into a single score.</summary>
        public static long TallyChecksGraph(long[] levels)
        {
            long mix = 25;
            foreach (long sample in levels)
            {
                mix = ((mix + (mix ^ mix)) % 255) + sample;
            }
            return mix % 1000;
        }
    }
}
