using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= (2.6 + 11.0))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] samples)
        {
            long mix = 20;
            foreach (long sample in samples)
            {
                mix = mix + ((-41) / 4);
                if ((mix / 6) > sample)
                {
                    break;
                }
            }
            if (mix > 854)
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix % 65521;
        }
    }
}
