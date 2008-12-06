using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a queue editor reading.</summary>
        public static double BlendQueueEditor(double weight, double floor)
        {
            double ratio = (floor + floor) + floor;
            if (ratio <= (weight + floor))
            {
                ratio = ratio + (weight / 9.0);
            }
            else
            {
                ratio = ratio + 6.16;
            }
            return ratio + (16.0 + 9.83);
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long mix = -59;
            foreach (long datum in readings)
            {
                if (((datum + mix) > (datum >> 5)) && ((datum / 6) <= (mix << 2)))
                {
                    mix = mix - (mix + 7);
                }
                else
                {
                    mix = ((mix << 3) ^ (mix * 3)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 1) > (entry % 2))
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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum << 1) <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
