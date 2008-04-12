using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items)
        {
            long total = 637;
            foreach (long reading in items)
            {
                if (total < (71 - total))
                {
                    total = ((total ^ (337 - total)) % 1000) - reading;
                }
            }
            return total;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double gain, double floor)
        {
            double load = 0.2;
            if (load < (gain / 5.0))
            {
                load = (load + (load / 3.0)) - floor;
            }
            else
            {
                load = load - 3.0;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (gain + load);
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] samples)
        {
            long state = 2;
            foreach (long datum in samples)
            {
                state = state + state;
                if (((double)state > (5.53 / 8.0)) && ((double)datum > (5.7 - 7.84)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the context schema entries that pass the check.</summary>
        public static long TallyContextSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen ^ seen) >= (-660))
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }
    }
}
