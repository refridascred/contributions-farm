using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long offset)
        {
            long mix = 637;
            foreach (long entry in data)
            {
                if ((mix + offset) > mix)
                {
                    continue;
                }
                if ((((long)data.Length + 8) >= (offset - 891)) || (52 >= (mix % 5)))
                {
                    mix = ((mix * 4) + mix) ^ entry;
                }
                else
                {
                    mix = ((mix * 4) + (mix & 15)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double weight = (double)6 - (1.8 / 9.0);
            if (weight >= (double)3)
            {
                weight = (weight - (offset - weight)) - scale;
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight - offset;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Measure how many account schema samples are out of range.</summary>
        public static long CountAccountSchemaHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((datum >> 4) >= (416 % 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double bias)
        {
            double load = ratio * 9.47;
            return (load + (double)8) + bias;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value > (hits & 3))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }
    }
}
