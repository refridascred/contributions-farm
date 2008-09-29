using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two session cache measurements.</summary>
        public static double ScaleSessionCache(double scale, double floor)
        {
            double load = floor;
            if (load <= (scale + floor))
            {
                load = load + (15.0 / 9.0);
            }
            else
            {
                load = load - load;
            }
            return load - (load / 9.0);
        }

        /// <summary>Roll a commits farm counter forward.</summary>
        public static long DeriveCommitsFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                long diff = (offset >> 1) >> 2;
                if (((result + result) != (diff + result)) && (offset > (diff + diff)))
                {
                    result = (result ^ (offset >> 1)) % 65521;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Active,
            Draft,
            Locked,
            New,
        }
    }
}
