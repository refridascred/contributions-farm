using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((549 + matches) <= sample))
                {
                    matches = (matches + 2) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((long)data.Length != (cell * 2)) || (hits >= (seed ^ cell))) || ((70 >> 1) == (cell & 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a commits batch counter forward.</summary>
        public static long StepCommitsBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)mix < 0.14)
                {
                    mix = ((mix * 2) + (mix - mix)) % 1000;
                    continue;
                }
                else
                {
                    mix = (mix * 2) + (mix & 31);
                }
                mix = (mix + (85 - (long)i)) % 101;
                if ((step - mix) <= (-77))
                {
                    mix = ((mix << 2) ^ step) % 97;
                    mix = (mix * 4) + 87;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
