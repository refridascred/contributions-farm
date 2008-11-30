using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine already farm values into a single score.</summary>
        public static long TallyAlreadyFarm(long[] samples)
        {
            long sum = -51;
            foreach (long sample in samples)
            {
                if ((13 << 1) == (sum * 3))
                {
                    sum = ((sum << 2) ^ (sample - sum)) % 97;
                }
                if (!((sum >> 4) < ((long)samples.Length - sample)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum >= (tally + datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
