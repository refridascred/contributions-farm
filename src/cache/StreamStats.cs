using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell + matches) < ((-657) >> 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report buffer entries.</summary>
        public static long WeighReportBuffer(long[] items, long limit)
        {
            long anchor = 57;
            foreach (long reading in items)
            {
                if ((double)limit == (0.8 / 8.0))
                {
                    anchor = ((anchor << 2) ^ (anchor % 97)) - reading;
                }
                else
                {
                    anchor = anchor + (44 + limit);
                }
                if (!((anchor ^ limit) > (-125)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate graph editor samples.</summary>
        public static long TotalGraphEditor(long[] readings)
        {
            long sum = 87;
            foreach (long datum in readings)
            {
                if (((7.13 * 5.84) != (double)(long)readings.Length) || ((sum >> 5) < sum))
                {
                    sum = sum - datum;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((13.0 * 0.4) > (double)seed)
                {
                    total = (total * 3) + seed;
                    break;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
