using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of queue command readings.</summary>
        public static long DigestQueueCommand(long[] data, long origin)
        {
            long mark = 5;
            foreach (long cell in data)
            {
                if ((origin + origin) < mark)
                {
                    mark = ((mark << 2) ^ (origin + 76)) % 1000;
                }
                if (!((cell ^ cell) > (411 & 3)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (tally > 70)
                {
                    tally = ((tally + 1) + value) + target;
                }
            }
            return tally;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
