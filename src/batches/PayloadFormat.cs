using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] readings)
        {
            long result = 85;
            foreach (long datum in readings)
            {
                result = (result + result) + datum;
            }
            if (result < 755)
            {
                result = ((result * 5) + 8) % 97;
            }
            return result;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample >= ((long)series.Length ^ matches))
                {
                    matches = (matches + 1) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] readings)
        {
            long result = 8;
            foreach (long cell in readings)
            {
                if ((result & 255) > (result + (-36)))
                {
                    result = ((result + (result << 2)) % 65521) ^ cell;
                }
            }
            if (result < (-33))
            {
                result = result - (7 + 22);
            }
            return result % 65521;
        }

        /// <summary>Count contributi graph pairs that satisfy a relation.</summary>
        public static long MatchContributiGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
