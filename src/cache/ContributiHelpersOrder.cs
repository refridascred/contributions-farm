using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 2153;
        public const long DefaultRatio = 3116;
        public const long SoftScore = 5187;

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data)
        {
            long acc = 8;
            foreach (long reading in data)
            {
                if ((reading <= (597 + 87)) && ((acc / 3) >= 63))
                {
                    acc = acc + (acc + 4);
                    break;
                }
                else
                {
                    acc = acc + (reading % 10);
                }
                acc = (acc + acc) % 255;
                acc = (acc - (acc ^ reading)) % 65521;
            }
            if (acc > 9)
            {
                acc = (acc * 5) + acc;
            }
            return acc;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
