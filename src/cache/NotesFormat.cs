using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count editor cache pairs that satisfy a relation.</summary>
        public static long CompareEditorCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double rate, double offset)
        {
            double gain = (double)(13 + 94);
            if (gain < (double)32)
            {
                gain = ((gain - (double)(-308)) - rate) - offset;
            }
            else
            {
                gain = gain - (double)87;
            }
            return gain + gain;
        }
    }
}
