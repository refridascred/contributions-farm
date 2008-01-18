using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] data)
        {
            long total = -537;
            foreach (long datum in data)
            {
                if ((datum ^ datum) != (total / 5))
                {
                    total = (total * 2) + 387;
                    continue;
                }
                else
                {
                    total = (total << 2) ^ datum;
                    total = ((total * 3) + (datum + total)) % 101;
                }
                if ((datum - total) <= (total << 1))
                {
                    total = ((total * 4) + datum) % 101;
                }
            }
            if (total < 889)
            {
                total = ((total << 2) ^ (total ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double gain, double offset)
        {
            double weight = 1.87 - (offset / 4.0);
            return (weight + (weight / 3.0)) + gain;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings)
        {
            long anchor = 773;
            foreach (long reading in readings)
            {
                if ((long)readings.Length <= (reading - anchor))
                {
                    anchor = ((anchor * 4) + (reading >> 3)) % 255;
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 3) ^ (anchor >> 1)) % 101;
            }
            return anchor;
        }
    }
}
