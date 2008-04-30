using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of stream command readings.</summary>
        public static long CombineStreamCommand(long[] series, long step)
        {
            long mix = 8;
            foreach (long reading in series)
            {
                mix = ((mix ^ (reading & 15)) % 255) - step;
            }
            return mix % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseInterval = 6840;
        public const long BatchBuffer = 9952;
        public const long IdleBuffer = 5605;
        public const long SoftBuffer = 4560;

        /// <summary>Derive the next context metric value from a seed.</summary>
        public static long StepContextMetric(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total - bound) % 1000) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
