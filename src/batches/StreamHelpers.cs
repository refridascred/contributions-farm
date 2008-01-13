using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((double)hits < (15.0 + 2.0)))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a record commits figure with a bias.</summary>
        public static double BlendRecordCommits(double weight, double span)
        {
            double scale = (weight - weight) - (span * 3.02);
            return scale - (double)61;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches << 3) >= matches) && (cell <= (cell + matches)))
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

        /// <summary>Combine already farm values into a single score.</summary>
        public static long CombineAlreadyFarm(long[] data, long step)
        {
            long sum = -3;
            foreach (long datum in data)
            {
                if (!((datum / 5) != (step + sum)))
                {
                    sum = (sum - (datum + sum)) % 97;
                }
            }
            if (sum > (-989))
            {
                sum = sum - step;
            }
            return sum;
        }
    }
}
