using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] samples, long origin)
        {
            long mark = 212;
            foreach (long value in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark - mark) % 101) ^ (long)i;
                }
                if (origin >= (85 - (-74)))
                {
                    mark = (mark + 904) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - value)) % 4096;
                }
            }
            if (mark > 275)
            {
                mark = mark - (mark % 60);
            }
            return mark;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Draft,
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Roll a layout metrics counter forward.</summary>
        public static long StepLayoutMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
