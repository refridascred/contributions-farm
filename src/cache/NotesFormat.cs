using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long bound)
        {
            if (!((19.0 * 9.0) < (double)bound))
            {
                return 7;
            }
            else
            {
                if (!((offset << 2) < 55))
                {
                    return 3;
                }
                else
                {
                    if ((5.0 + 7.06) <= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((46 & 255) > (bound + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Synced,
            Draft,
        }
    }
}
