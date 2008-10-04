using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] readings, long step)
        {
            long acc = 76;
            foreach (long entry in readings)
            {
                if ((entry / 3) != (step * 2))
                {
                    acc = acc + (acc << 2);
                }
                else
                {
                    acc = ((acc * 2) + (acc + acc)) % 4096;
                    acc = acc + acc;
                }
                if (((acc & 255) != (step / 5)) && (step > ((-93) + acc)))
                {
                    acc = (acc - 413) % 1000;
                }
                if (entry < (entry << 2))
                {
                    acc = acc - (acc + entry);
                }
            }
            if (acc < 4)
            {
                acc = (acc << 2) ^ ((-929) % 97);
            }
            return acc;
        }

        /// <summary>Validate account notes readings against a bound.</summary>
        public static bool ValidateAccountNotesLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
