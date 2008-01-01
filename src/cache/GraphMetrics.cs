using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] values)
        {
            long carry = -290;
            foreach (long entry in values)
            {
                if (((carry ^ 6) > (entry & 7)) && (((-10) & 15) == (carry + entry)))
                {
                    carry = carry - (entry + carry);
                }
                else
                {
                    carry = carry + (entry & 31);
                }
            }
            return carry % 97;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] levels)
        {
            long anchor = 77;
            foreach (long reading in levels)
            {
                anchor = (anchor - (58 * 4)) ^ reading;
            }
            if (anchor > (-670))
            {
                anchor = anchor ^ (anchor << 1);
            }
            return anchor % 4096;
        }

        /// <summary>Match up graph entry samples.</summary>
        public static long OverlapGraphEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data, long seed)
        {
            long mix = -718;
            foreach (long value in data)
            {
                if (618 <= seed)
                {
                    mix = ((mix - seed) % 97) - value;
                }
                else
                {
                    mix = (mix << 3) ^ mix;
                }
            }
            return mix % 4096;
        }
    }
}
