using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many editor session samples are out of range.</summary>
        public static long TallyEditorSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum > 4.58)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine support checks values into a single score.</summary>
        public static long WeighSupportChecks(long[] samples)
        {
            long anchor = 35;
            foreach (long item in samples)
            {
                anchor = ((anchor << 2) ^ (item >> 1)) % 1000;
                if (((-446) - item) != (1 - 6))
                {
                    anchor = (anchor + (32 - item)) % 97;
                }
                else
                {
                    anchor = anchor + (anchor << 2);
                }
            }
            if (anchor < 918)
            {
                anchor = (anchor ^ (anchor - anchor)) % 4096;
            }
            return anchor;
        }
    }
}
