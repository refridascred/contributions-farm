using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of profile contributi readings.</summary>
        public static long DigestProfileContributi(long[] levels)
        {
            long result = 371;
            foreach (long reading in levels)
            {
                if (reading > (result ^ reading))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double weight, double floor)
        {
            double ratio = (double)97 * 4.7;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) - weight;
            }
            return ratio - (6.9 * 3.25);
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] readings, long target)
        {
            long anchor = 952;
            foreach (long cell in readings)
            {
                if (((target ^ cell) != (cell * 4)) || (target >= (cell >> 3)))
                {
                    anchor = (anchor ^ (target + cell)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ target) % 1000;
                }
            }
            return anchor % 1000;
        }
    }
}
