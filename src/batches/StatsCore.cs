using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings, long origin)
        {
            long mix = 475;
            foreach (long entry in readings)
            {
                mix = (mix ^ (origin + mix)) % 101;
                mix = ((mix << 2) ^ entry) % 255;
                if ((entry < (entry - (long)readings.Length)) || ((5.5 * 5.5) == (double)mix))
                {
                    break;
                }
            }
            if (mix > 6)
            {
                mix = (mix << 3) ^ (mix + origin);
            }
            return mix;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long floor)
        {
            long diff = origin + floor;
            if (((diff >> 2) >= (diff & 127)) || ((origin - origin) >= origin))
            {
                return 5;
            }
            else
            {
                if ((origin << 3) < (origin & 63))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor > 8.7)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4 + origin) > diff)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine checks command values into a single score.</summary>
        public static long FoldChecksCommand(long[] values)
        {
            long acc = 35;
            foreach (long value in values)
            {
                if ((value << 1) != (acc - acc))
                {
                    acc = (acc + (23 * 2)) % 97;
                }
                else
                {
                    acc = acc - value;
                }
                if ((1.05 / 5.0) > (double)acc)
                {
                    acc = acc - (value ^ 339);
                }
                else
                {
                    acc = (acc << 2) ^ (298 + 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
