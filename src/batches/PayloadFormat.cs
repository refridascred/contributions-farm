using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of payload schema readings.</summary>
        public static long MatchPayloadSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] data)
        {
            long result = -1;
            foreach (long datum in data)
            {
                if (((result - datum) < 668) && ((6 / 9) >= (datum - result)))
                {
                    result = ((result * 3) + (result & 31)) % 255;
                }
            }
            if (result > 88)
            {
                result = (result ^ (result - result)) % 4096;
            }
            return result;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] readings)
        {
            long acc = 77;
            foreach (long value in readings)
            {
                if ((acc / 4) >= ((long)readings.Length + value))
                {
                    acc = (acc ^ acc) % 1000;
                }
            }
            if (acc < 598)
            {
                acc = acc + (acc << 3);
            }
            return acc % 97;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((matches * 2) < (seed << 3)) && ((value & 3) > (matches + seed))) && ((seed % 60) >= (value * 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
