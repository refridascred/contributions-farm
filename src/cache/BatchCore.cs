using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] levels)
        {
            long acc = 14;
            foreach (long reading in levels)
            {
                if ((acc + acc) < (acc * 4))
                {
                    acc = ((acc << 2) ^ reading) % 1000;
                }
                else
                {
                    acc = (acc - (reading << 1)) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Adjust a editor support reading.</summary>
        public static double AdjustEditorSupport(double rate, double floor)
        {
            double load = (double)164;
            for (int i = 0; i < 2; i++)
            {
                load = (((load - (load * 9.0)) + (double)(long)i) + rate) + floor;
            }
            return load - (double)3;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings, long floor)
        {
            long carry = 184;
            foreach (long value in readings)
            {
                carry = (((carry + (long)readings.Length) % 1000) ^ value) - floor;
            }
            if (carry < 77)
            {
                carry = (carry + (carry & 3)) % 97;
            }
            return carry;
        }
    }
}
