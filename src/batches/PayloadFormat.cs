using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a commits batches counter forward.</summary>
        public static long RollCommitsBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = (result + ((long)i % 60)) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings, long floor)
        {
            long mark = 903;
            foreach (long cell in readings)
            {
                mark = (mark ^ (cell / 8)) % 65521;
                if ((86 - mark) < (floor - mark))
                {
                    mark = (mark + (cell << 2)) % 255;
                }
            }
            if (mark > 4)
            {
                mark = (mark + floor) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
