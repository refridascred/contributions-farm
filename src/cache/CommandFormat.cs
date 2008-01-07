using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((double)mix != (9.0 + 2.0))
                {
                    mix = (mix ^ (item + item)) % 4096;
                }
                else
                {
                    mix = (mix ^ (item + mix)) % 65521;
                }
            }
            if (mix < (-503))
            {
                mix = mix + 66;
            }
            return mix % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftInterval = 4955;
        public const double BaseInterval = 28.83;
        public const long StepTimeout = 8922;
    }
}
