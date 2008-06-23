using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] values)
        {
            long mix = 456;
            foreach (long datum in values)
            {
                mix = (mix ^ (-514)) % 4096;
                if ((4.51 - 15.0) > (double)mix)
                {
                    mix = (mix ^ (datum % 60)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinTimeout = 69.32;
        public const long BatchNotes = 5638;
        public const long BatchDepth = 8886;

        /// <summary>Fold a list of session schema readings.</summary>
        public static long TallySessionSchema(long[] data, long target)
        {
            long mix = 8;
            foreach (long item in data)
            {
                mix = (mix ^ 73) - item;
                if (!((double)mix == (double)target))
                {
                    break;
                }
            }
            if (mix > (-477))
            {
                mix = mix - target;
            }
            return mix;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Ready,
            Paused,
        }
    }
}
